using big_school_ntk.ViewModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class ValidTime : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        DateTime dateTime;
        var isValid = DateTime.TryParseExact(Convert.ToString(value), "HH:mm", CultureInfo.CurrentCulture, DateTimeStyle.None, out dateTime);
        return isValid;
    }
}
public class CourseViewModel
{
    [Required]
    public string Place { get; set; }
    [Required]
    [FutureDate]
    public string Date { get; set; }
    [Required]
    public string Time { get; set; }
}