namespace GoodsFlow.Catppuccin;

public enum CatppuccinColor
{
    Crust,
    Mantle,
    Base,
    Surface0,
    Surface1,
    Surface2,
    Overlay0,
    Overlay1,
    Overlay2,
    Subtext0,
    Subtext1,
    Text,
    Lavender,
    Blue,
    Sapphire,
    Sky,
    Teal,
    Green,
    Yellow,
    Peach,
    Maroon,
    Red,
    Mauve,
    Pink,
    Flamingo,
    Rosewater
}

public class CatppuccinPallette {
    public static bool DarkTheme = true;

    private static readonly Dictionary<CatppuccinColor, Color> Mocha = new() {
        [CatppuccinColor.Crust] = ColorTranslator.FromHtml("#11111b"),
        [CatppuccinColor.Mantle] = ColorTranslator.FromHtml("#181825"),
        [CatppuccinColor.Base] = ColorTranslator.FromHtml("#1e1e2e"),
        [CatppuccinColor.Surface0] = ColorTranslator.FromHtml("#313244"),
        [CatppuccinColor.Surface1] = ColorTranslator.FromHtml("#313244"),
        [CatppuccinColor.Surface2] = ColorTranslator.FromHtml("#585b70"),
        [CatppuccinColor.Overlay0] = ColorTranslator.FromHtml("#585b70"),
        [CatppuccinColor.Overlay1] = ColorTranslator.FromHtml("#6c7086"),
        [CatppuccinColor.Overlay2] = ColorTranslator.FromHtml("#9399b2"),
        [CatppuccinColor.Subtext0] = ColorTranslator.FromHtml("#a6adc8"),
        [CatppuccinColor.Subtext1] = ColorTranslator.FromHtml("#bac2de"),
        [CatppuccinColor.Text] = ColorTranslator.FromHtml("#bac2de"),
        [CatppuccinColor.Lavender] = ColorTranslator.FromHtml("#b4befe"),
        [CatppuccinColor.Blue] = ColorTranslator.FromHtml("#89b4fa"),
        [CatppuccinColor.Sapphire] = ColorTranslator.FromHtml("#74c7ec"),
        [CatppuccinColor.Sky] = ColorTranslator.FromHtml("#89dceb"),
        [CatppuccinColor.Teal] = ColorTranslator.FromHtml("#94e2d5"),
        [CatppuccinColor.Green] = ColorTranslator.FromHtml("#a6e3a1"),
        [CatppuccinColor.Yellow] = ColorTranslator.FromHtml("#f9e2af"),
        [CatppuccinColor.Peach] = ColorTranslator.FromHtml("#fab387"),
        [CatppuccinColor.Maroon] = ColorTranslator.FromHtml("#eba0ac"),
        [CatppuccinColor.Red] = ColorTranslator.FromHtml("#f38ba8"),
        [CatppuccinColor.Mauve] = ColorTranslator.FromHtml("#cba6f7"),
        [CatppuccinColor.Pink] = ColorTranslator.FromHtml("#cba6f7"),
        [CatppuccinColor.Flamingo] = ColorTranslator.FromHtml("#f5c2e7"),
        [CatppuccinColor.Rosewater] = ColorTranslator.FromHtml("#f2cdcd")
    };

    private static readonly Dictionary<CatppuccinColor, Color> Latte = new() {
        [CatppuccinColor.Crust] = ColorTranslator.FromHtml("#f5e0dc"),
        [CatppuccinColor.Mantle] = ColorTranslator.FromHtml("#dce0e8"),
        [CatppuccinColor.Base] = ColorTranslator.FromHtml("#e6e9ef"),
        [CatppuccinColor.Surface0] = ColorTranslator.FromHtml("#eff1f5"),
        [CatppuccinColor.Surface1] = ColorTranslator.FromHtml("#ccd0da"),
        [CatppuccinColor.Surface2] = ColorTranslator.FromHtml("#bcc0cc"),
        [CatppuccinColor.Overlay0] = ColorTranslator.FromHtml("#acb0be"),
        [CatppuccinColor.Overlay1] = ColorTranslator.FromHtml("#8c8fa1"),
        [CatppuccinColor.Overlay2] = ColorTranslator.FromHtml("#7c7f93"),
        [CatppuccinColor.Subtext0] = ColorTranslator.FromHtml("#7c7f93"),
        [CatppuccinColor.Subtext1] = ColorTranslator.FromHtml("#6c6f85"),
        [CatppuccinColor.Text] = ColorTranslator.FromHtml("#5c5f77"),
        [CatppuccinColor.Lavender] = ColorTranslator.FromHtml("#7287fd"),
        [CatppuccinColor.Blue] = ColorTranslator.FromHtml("#7287fd"),
        [CatppuccinColor.Sapphire] = ColorTranslator.FromHtml("#1e66f5"),
        [CatppuccinColor.Sky] = ColorTranslator.FromHtml("#209fb5"),
        [CatppuccinColor.Teal] = ColorTranslator.FromHtml("#179299"),
        [CatppuccinColor.Green] = ColorTranslator.FromHtml("#40a02b"),
        [CatppuccinColor.Yellow] = ColorTranslator.FromHtml("#df8e1d"),
        [CatppuccinColor.Peach] = ColorTranslator.FromHtml("#df8e1d"),
        [CatppuccinColor.Maroon] = ColorTranslator.FromHtml("#e64553"),
        [CatppuccinColor.Red] = ColorTranslator.FromHtml("#d20f39"),
        [CatppuccinColor.Mauve] = ColorTranslator.FromHtml("#8839ef"),
        [CatppuccinColor.Pink] = ColorTranslator.FromHtml("#ea76cb"),
        [CatppuccinColor.Flamingo] = ColorTranslator.FromHtml("#dd7878"),
        [CatppuccinColor.Rosewater] = ColorTranslator.FromHtml("#dc8a78")
    };

    public static Color GetColor(CatppuccinColor Name)
    {
        return (DarkTheme ? Mocha : Latte)[Name];
    }
}
