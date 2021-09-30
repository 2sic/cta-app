using ToSic.Razor.Blade;

public class Helpers: Custom.Hybrid.Code12
{
      public dynamic WrapperStyleAttribute(dynamic data) {
            return Text.Has(data.BackgroundImage) 
                  ? "background-image: url('" + Link.Image(url: data.BackgroundImage, width: 1920, quality: 70) + "')" 
                  : "";
      }
}

// <text>style='@(Text.Has(data.BackgroundImage) 
//       ? "background-image: url('" + data.BackgroundImage + "?w=1920&amp;scale=both&amp;quality=70&amp;anchor=" + data.CropAnchor + "')"
//       : "")'</text>
// }