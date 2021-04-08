using Microsoft.AspNetCore.Mvc;
using Swagger_API.Context;
using Swagger_API.Logging;
using Swagger_API.Models;
using Swagger_API.Models.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Swagger_API.Repository_Entity
{
    public class BatchFileRepository : IRepository
    {
        private readonly CRUDContext _CRUDContext;
        private readonly ILoggerManager _logger;
        public BatchFileRepository(CRUDContext CRUDContext, ILoggerManager logger)
        {
            _CRUDContext = CRUDContext;
            _logger = logger;
        }
        public bool GetBybatchIdAsync(string batchID)
        {
            if (_CRUDContext.BatchTables.SingleOrDefault(x => x.BatchID == batchID) == null)
            {
                _logger.LogError("Invalid input batchid." + batchID);
                return false;
            }
            return true;
        }
        public  string SaveBatchFile(CreateBatchViewModel batchfile)
        {
            try
            {
                int Aci_ID;
                string batchid = Guid.NewGuid().ToString();

                Aci_ID = _CRUDContext.BatchAclTables.Max(BatchAcl => BatchAcl.AciID) + 1;

                _CRUDContext.BatchTables.Add(new BatchTable()
                {
                    BatchID = batchid,
                    BusinessUnit = batchfile.BusinessUnit,
                    EmpiryDate = batchfile.EmpiryDate,
                    Publishdate = DateTime.Now
                }); ;

                _CRUDContext.BatchAclTables.Add(new BatchAclTable()
                {
                    BatchID = batchid,
                    AciID = Aci_ID
                }); ;

                if (batchfile.acl != null && batchfile.acl.readGroups != null && batchfile.acl.readGroups.Any())
                {
                    foreach (var item in batchfile.acl.readGroups)
                    {
                        _CRUDContext.BatchAclReadGroupsTables.Add(new BatchAclReadGroupsTable()
                        {
                            AciID = Aci_ID,
                            Groupdetail = item
                        }); ;
                    }
                }

                if (batchfile.acl != null && batchfile.acl.readUsers != null && batchfile.acl.readUsers.Any())
                {
                    foreach (var item in batchfile.acl.readGroups)
                    {
                        _CRUDContext.BatchAclReadUsersTables.Add(new BatchAclReadUsersTable()
                        {
                            AciID = Aci_ID,
                            Usersdetail = item
                        }); ;
                    }
                }

                if (batchfile.attribute != null && batchfile.attribute.Any())
                {
                    var attEntity = new List<BatchAttributeTable>();
                    foreach (var item in batchfile.attribute)
                    {
                        attEntity.Add(new BatchAttributeTable
                        {
                            Keydetail = item.Key,
                            Valuedetail = item.Value,
                            BatchID = batchid
                        });
                    }
                     _CRUDContext.BatchAttributeTables.AddRangeAsync(attEntity);
                }

                _logger.LogInfo("Data has been saved successfully! Batchid" + batchfile);
                _CRUDContext.SaveChanges();
                return batchid ;

            }
            catch (Exception exception)
            {
                _logger.LogError(exception);
                 throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest)); 

            }

        }
        public List<ResponseBatchViewModel> GetDetail(string batchID)
        { 
                var batchdetail = (from e in _CRUDContext.BatchTables
                                   join c in _CRUDContext.BatchAclTables on e.BatchID equals c.BatchID
                                   where e.BatchID == batchID
                                   select new ResponseBatchViewModel
                                   {
                                       batchId = e.BatchID,
                                       status = "Incomplete",
                                       attribute = (from e in _CRUDContext.BatchAttributeTables
                                                    where e.BatchID == batchID
                                                    select new CreateAttributeViewModel
                                                    {
                                                        Key = e.Keydetail,
                                                        Value = e.Valuedetail
                                                    }).ToList(),
                                       acl = new ResponseAclViewModel
                                       {
                                           readGroups = _CRUDContext.BatchAclReadGroupsTables.Where(a => a.AciID == c.AciID).Select(b => b.Groupdetail).ToList(),
                                           readUsers = _CRUDContext.BatchAclReadUsersTables.Where(a => a.AciID == c.AciID).Select(b => b.Usersdetail).ToList()

                                       },
                                       BusinessUnit = e.BusinessUnit,
                                       batchPublishdate = e.Publishdate,
                                       expireDate = e.EmpiryDate

                                   }).ToList();
                _logger.LogInfo("Data has been saved successfully! Batchid:-" + batchID);
                return batchdetail;
            }
    }
}

