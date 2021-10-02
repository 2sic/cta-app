using ToSic.Razor.Blade;

public class Helpers: Custom.Hybrid.Code12
{
  // todo: 
  // - in @functions verschieben (zu wenig code für die komplexität eines  Helpers)
  // - return-type string, nicht dynamic
  // info @2mh - I now use settings for resize, height:0 means don't use the height in the settings
  // this is better, because if the layout changes, all apps which use settigs will change their size
      public dynamic WrapperStyleAttribute(dynamic data) {
            return Text.Has(data.BackgroundImage) 
                  ? "background-image: url('" + Link.Image(data.BackgroundImage, Settings.Images.Section, height: 0) + "')" 
                  : "";
      }
}

// <text>style='@(Text.Has(data.BackgroundImage) 
//       ? "background-image: url('" + data.BackgroundImage + "?w=1920&amp;scale=both&amp;quality=70&amp;anchor=" + data.CropAnchor + "')"
//       : "")'</text>
// }