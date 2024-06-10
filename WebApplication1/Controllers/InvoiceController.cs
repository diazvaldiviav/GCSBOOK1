using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : BaseApiController
    {
        private readonly BookContext _context;

        public InvoiceController (BookContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetInvoice")]

        public async Task<ActionResult> GetInvoice()
        {
            var invoice = await _context.Invoices
                 .Include(i => i.Items)
                 .FirstOrDefaultAsync(); ;

            if (invoice == null) { return NotFound(); }

            return Ok(invoice);
        }

        public async Task<ActionResult<Invoice>> AddItemToInvoice(int invoiceId, string name, string description)
        {

            //get invoice || create item
            var invoice = await RetrieveInvoice(invoiceId);

            //add item
            invoice.AddItem(name, description);

            //save changes

            var result = await _context.SaveChangesAsync() > 0;

            if (result) return CreatedAtRoute("GetInvoice", invoice);

            return BadRequest(new ProblemDetails { Title = "Problem saving item to invoice" });
        }

    

        private async Task<Invoice> RetrieveInvoice(int id)
        {
            if (id == null)
            {
                return await _context.Invoices
                 .Include(i => i.Items)
                 .FirstOrDefaultAsync();
            }

            return await _context.Invoices.Include(i => i.Items).FirstOrDefaultAsync(item => item.Id == id);
           
        }
    }
}
