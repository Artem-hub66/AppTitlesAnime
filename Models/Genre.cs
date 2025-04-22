using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Models;

public partial class Genre
{
    public short Id { get; set; }

    public string GenresName { get; set; } = null!;

    //навигационные свойства
    public virtual ICollection<AnimeTitlesGenre> AnimeTitlesGenres { get; set; } = new List<AnimeTitlesGenre>();

    public static implicit operator Genre(Type v)
    {
        throw new NotImplementedException();
    }
}
