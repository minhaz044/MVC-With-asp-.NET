using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleCRUD.Models;

namespace SimpleCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberDetailsController : ControllerBase
    {
        private readonly PaymentDetailContext _context;

        public MemberDetailsController(PaymentDetailContext context)
        {
            _context = context;
        }

        // GET: api/MemberDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDetail>>> GetMemberDetail_1()
        {
            return await _context.MemberDetail.ToListAsync();
        }

        // GET: api/MemberDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MemberDetail>> GetMemberDetail(int id)
        {
            var memberDetail = await _context.MemberDetail.FindAsync(id);

            if (memberDetail == null)
            {
                return NotFound();
            }

            return memberDetail;
        }

        // PUT: api/MemberDetails/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMemberDetail(int id, MemberDetail memberDetail)
        {
            if (id != memberDetail.MyProperty)
            {
                return BadRequest();
            }

            _context.Entry(memberDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MemberDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MemberDetails
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MemberDetail>> PostMemberDetail(MemberDetail memberDetail)
        {
            _context.MemberDetail.Add(memberDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMemberDetail", new { id = memberDetail.MyProperty }, memberDetail);
        }

        // DELETE: api/MemberDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MemberDetail>> DeleteMemberDetail(int id)
        {
            var memberDetail = await _context.MemberDetail.FindAsync(id);
            if (memberDetail == null)
            {
                return NotFound();
            }

            _context.MemberDetail.Remove(memberDetail);
            await _context.SaveChangesAsync();

            return memberDetail;
        }

        private bool MemberDetailExists(int id)
        {
            return _context.MemberDetail.Any(e => e.MyProperty == id);
        }
    }
}
