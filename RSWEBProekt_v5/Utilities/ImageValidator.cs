using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEBProekt_v1.Utilities
{
    public class ImageValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int MaxContentLength = 1024 * 1024 * 2;
            string[] AllowedFileExtensions = new string[] { ".jpg", ".png", ".jpeg" };
            var file = value as IFormFile;
            if(file !=null)
            {
                if (!AllowedFileExtensions.Contains(file.FileName.Substring(file.FileName.LastIndexOf('.'))))
                {
                    ErrorMessage = "Please upload Your Photo of type: " + string.Join(", ", AllowedFileExtensions);
                    return false;
                }
                else if(file.Length > MaxContentLength)
                {
                    ErrorMessage = "File is too large, maximum size is : " + (MaxContentLength / 1024).ToString() + "MB";
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
