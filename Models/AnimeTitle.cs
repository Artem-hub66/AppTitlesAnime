using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Models;

public partial class AnimeTitle
{
    private Type type = null!;

    public int Id { get; set; }

    public short IdType { get; set; }

    public string OriginalName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public short Duration { get; set; }

    public short CountSeries { get; set; }

    public string? Description { get; set; }

    public string Studio { get; set; } = null!;

    public string? Poster { get; set; }

    //навигационные свойства
    public virtual ICollection<AnimeTitlesGenre> AnimeTitlesGenres { get; set; } = new List<AnimeTitlesGenre>();

    public virtual Type Type { get => type; set => type = value; }
    public virtual ICollection<TitlesStatus> TitlesStatuses { get; set; } = new List<TitlesStatus>();
}
