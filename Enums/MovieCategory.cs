using System.ComponentModel;

namespace MovieAddictPro.Enums
{
    public enum MovieCategory
    {
        [Description("Now Playing")]
        now_playing,
        [Description("Popular")]
        popular,
        [Description("Top Rated")]
        top_rated,
        [Description("Upcoming")]
        upcoming
    }
}
