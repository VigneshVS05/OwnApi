using Microsoft.AspNetCore.Mvc;
using ImageWebapi.Models;



namespace ImageWebapi.Controllers;

[ApiController]
[Route("api/Image")]
public class ImageController : ControllerBase
{
    private readonly ImagesssContext DB;
    public  ImageController(ImagesssContext db)
    {
        this.DB = db;

    }
  [HttpGet("GetAllImages/{Catg}")]
  public Imagesss GetAllImages(string Catg)
  {
    try
    {
        return DB.Imagessses.Where(y =>y.Categories.Equals(Catg)).FirstOrDefault();
    }
    catch(System.Exception)
    {
        throw;
    }
  }
}
