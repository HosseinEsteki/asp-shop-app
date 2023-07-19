using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using ShopApp.Models;

namespace ShopApp.Data.Process
{
    public class ImageProcess
    {
        readonly ShopAppDBContext db;
        public int Id { get; set; }
        public string Folder { get; set; }
        public ImageProcess(int id, string folder)
        {
            db = new ShopAppDBContext();
            Id=id;
            Folder=folder.ToLower();
            
        }
        string GetFilePath(string fileName)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "image",
                    Folder,
                    fileName);
            return path;
        }
        public void AddImage(IFormFile file)
        {
            string fileName=$"{Id}.";
            switch (file.ContentType)
            {
                case "image/jpeg":
                    fileName += "jpg";
                    break;
                case "image/png":
                    fileName += "png";
                    break;
            }
                Image image = new Image();
                image.FileName= fileName;
                switch (Folder)
                {
                    case "category":
                        image.CategoryId = Id;
                        break;
                    case "user":
                        image.UserId = Id;
                        break;
                    case "product":
                        image.ProductId = Id;
                        break;
                }
                db.Images.Add(image);
                db.SaveChangesAsync();
            string filePath = GetFilePath(fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
        }
        public async void RemoveImage(Image image)
        {
            File.Delete(GetFilePath(image.FileName));
            db.Images.Remove(image);
            await db.SaveChangesAsync();
        }
    }
}
