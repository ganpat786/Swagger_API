using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swagger_API.Context;
using Swagger_API.Logging;
using Swagger_API.Models;
using Swagger_API.Models.View_Model;
using Swagger_API.Repository_Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Twilio.Rest;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Swagger_API.Controllers
{
    [ApiController]
    public class BatchFileController : ControllerBase
    {
        private IRepository batchFileRepository;

        public BatchFileController(IRepository batchFileRepository)
        {
            this.batchFileRepository = batchFileRepository;
        }

        //GET api/<BatchFileController>/5
    [HttpGet("batch/{batchID}")]
        
        public ActionResult Get(string batchID, CancellationToken ct = default(CancellationToken))
        {
            if (batchFileRepository.GetBybatchIdAsync(batchID) == false)
            {
                return NotFound();
            }
            try
            {
                var batchdetail = batchFileRepository.GetDetail(batchID);
                return Ok(batchdetail.FirstOrDefault());
            }
            catch
            {
                return BadRequest();
            }
        }
    //}

    // POST api/<BatchFileController>
    [HttpPost("/batch")]
        public async Task<ActionResult<CreateBatchViewModel>> Post([FromBody] CreateBatchViewModel batchfile)
        {
            try
            {
                var batchid = batchFileRepository.SaveBatchFile(batchfile);

                if (batchid == null)
                 { return BadRequest(); }

                return Ok(new { batchid });
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
