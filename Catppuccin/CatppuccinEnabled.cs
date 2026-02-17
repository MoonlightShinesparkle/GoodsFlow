namespace GoodsFlow.Catppuccin;

public interface ICatppuccinEnabled
{
    public CatppuccinColor BackgroundColor { get; set; }

    public CatppuccinColor ForegroundColor { get; set; }

    public void ApplyCatppuccin();
}
