using System.ComponentModel;
using System.Windows.Forms;

namespace GoodsFlow.Catppuccin.Components;

public class CatppuccinButton : Button, ICatppuccinEnabled
{
    public CatppuccinButton() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Crust;
    private CatppuccinColor FCC = CatppuccinColor.Crust;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor {
        get => BCC; set {
            BCC = value;
            ApplyCatppuccin();
        } 
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor {
        get => FCC; set { 
            FCC = value; 
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}

public class CatppuccinForm : Form, ICatppuccinEnabled
{
    public CatppuccinForm() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Crust;
    private CatppuccinColor FCC = CatppuccinColor.Crust;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}