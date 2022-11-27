using AliBabaCodeChallenge.Domain.Dto;
using AliBabaCodeChallenge.Domain.QueryModels;
using AliBabaCodeChallenge.WebApi.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace AliBabaCodeChallenge.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    private readonly IContactService contactService;
    private readonly IMapper mapper;
    public ContactController(IContactService contactService, IMapper mapper)
    {
        this.contactService = contactService;
        this.mapper = mapper;
    }
    [HttpGet("{id}")]
    [SwaggerOperation(
    Summary = "Get Contacts",
    Description = "Get Contact With id",
    OperationId = "Contacts.Get",
    Tags = new[] { "ContactController", }
)]
    public async Task<IActionResult> Get(int id)
    {
        try
        {
            var result = await contactService.Get(id);
            var viewModel = mapper.Map<ContactViewModel>(result);
            if (viewModel is not null)
                return Ok(viewModel);
            else
            {
                var content = new ContentResult() { Content = "Contact with the specified Id not found!" };

                return content;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            var content = new ContentResult() { Content = ex.Message };

            return content;
        }


    }

    [HttpGet]
    [SwaggerOperation(
    Summary = "Get Contacts",
    Description = "Get All Contact",
    OperationId = "Contacts.GetAll",
    Tags = new[] { "ContactController", }
    )]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var result = await contactService.GetAll();
            var viewModel = mapper.Map<List<ContactViewModel>>(result);

            return Ok(viewModel);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            var content = new ContentResult() { Content = ex.Message };

            return content;
        }
    }

    [HttpPost]
    [SwaggerOperation(
    Summary = "Create Contacts",
    Description = "Create Contact",
    OperationId = "Contacts.Create",
    Tags = new[] { "ContactController", }
    )]
    public async Task<IActionResult> Create(CreateContactViewModel model)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var result = await contactService.Add(mapper.Map<ContactDto>(model));
                var viewModel = mapper.Map<ContactViewModel>(result);

                return Ok(viewModel);
            }
            else
            {
                string message = string.Empty;
                foreach (var modelStateValue in ModelState.Values.ToList())
                    foreach (var error in modelStateValue.Errors.ToList())
                        message += error.ErrorMessage + Environment.NewLine;

                var content = new ContentResult() { Content = message };

                return content;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

            var content = new ContentResult() { Content = ex.Message };

            return content;
        }
    }

    [HttpGet("Search Contacts")]
    [SwaggerOperation(
    Summary = "Search Contacts",
    Description = "Search Contact",
    OperationId = "Contacts.Search",
    Tags = new[] { "ContactController", }
    )]
    public async Task<IActionResult> SearchAsync([FromQuery] ContactQueryModel model)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var result = await contactService.SearchAsync(model);
                var viewModel = mapper.Map<List<ContactViewModel>>(result);

                return Ok(viewModel);
            }
            else
            {
                string message = string.Empty;
                foreach (var modelStateValue in ModelState.Values.ToList())
                    foreach (var error in modelStateValue.Errors.ToList())
                        message += error.ErrorMessage + Environment.NewLine;

                var content = new ContentResult() { Content = message };

                return content;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

            var content = new ContentResult() { Content = ex.Message };

            return content;
        }
    }

    [HttpPut("Update Contacts")]
    [SwaggerOperation(
    Summary = "Update Contacts",
    Description = "Update Contact",
    OperationId = "Contacts.Update",
    Tags = new[] { "ContactController", }
    )]
    public IActionResult Update(UpdateContactViewModel contactViewModel)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var result = contactService.Update(mapper.Map<ContactDto>(contactViewModel));
                var content = new ContentResult() { Content = "The Update Opration has been successful!" };

                return content;
            }
            else
            {
                string message = string.Empty;
                foreach (var modelStateValue in ModelState.Values.ToList())
                    foreach (var error in modelStateValue.Errors.ToList())
                        message += error.ErrorMessage + Environment.NewLine;

                var content = new ContentResult() { Content = message };

                return content;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            var content = new ContentResult() { Content = ex.Message };

            return content;
        }
    }
    [HttpDelete("Delete Contacts")]
    [SwaggerOperation(
     Summary = "Delete Contacts",
     Description = "Delete Contact",
     OperationId = "Contacts.Delete",
     Tags = new[] { "ContactController", }
     )]

    public IActionResult Delete(int id)
    {
        try
        {
            var result = contactService.Delete(id);
            if (result)
                return Ok(result);
            else
            {
                var content = new ContentResult() { Content = "Contact with the specified Id not found!" };

                return content;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            var content = new ContentResult() { Content = ex.Message };

            return content;
        }
    }

}
