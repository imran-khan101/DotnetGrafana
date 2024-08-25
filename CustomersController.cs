using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
{
    private static List<Customer> customers = new List<Customer>
    {
        new Customer { Id = 1, Name = "John Doe", Email = "john@example.com", Phone = "123456789" },
        new Customer { Id = 2, Name = "Jane Doe", Email = "jane@example.com", Phone = "987654321" }
    };

    [HttpGet]
    public IActionResult Get() => Ok(customers);

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var customer = customers.FirstOrDefault(c => c.Id == id);
        if (customer == null)
            return NotFound();
        return Ok(customer);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Customer customer)
    {
        customer.Id = customers.Count + 1;
        customers.Add(customer);
        return CreatedAtAction(nameof(Get), new { id = customer.Id }, customer);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Customer customer)
    {
        var existingCustomer = customers.FirstOrDefault(c => c.Id == id);
        if (existingCustomer == null)
            return NotFound();

        existingCustomer.Name = customer.Name;
        existingCustomer.Email = customer.Email;
        existingCustomer.Phone = customer.Phone;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var customer = customers.FirstOrDefault(c => c.Id == id);
        if (customer == null)
            return NotFound();

        customers.Remove(customer);
        return NoContent();
    }
}
