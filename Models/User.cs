#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
public class User
{
    [ Required( ErrorMessage = "is required" ) ]
    [ MinLength( 2, ErrorMessage = "must be at least 2 characters" ) ]
    public string Name { get; set; }

    public string DojoLocation { get; set; }

    public string FavoriteLanguage { get; set; }
    
    
    public string Comment { get; set; }
}

