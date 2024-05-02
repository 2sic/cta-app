// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "CtaContent.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class CtaContent
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.06.04
// App/Edition: Call To Action/
// User:        2sic Web-Developer
// When:        2024-04-24 06:57:08Z
using System.Collections.Generic;

namespace AppCode.Data
{
  // This is a generated class for CtaContent 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// CtaContent data. <br/>
  /// Generated 2024-04-24 06:57:08Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Buttons`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class CtaContent: AutoGenerated.ZagCtaContent
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.CtaContent in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagCtaContent: Custom.Data.CustomItem
  {
    /// <summary>
    /// Buttons as list of Button.
    /// </summary>
    /// <remarks>
    /// Generated to return child-list child because field settings had Multi-Value=true. The type Button was specified in the field settings.
    /// </remarks>
    /// <returns>
    /// An IEnumerable of specified type, but can be empty.
    /// </returns>
    public IEnumerable<Button> Buttons => _buttons ??= _item.Children<Button>("Buttons");
    private IEnumerable<Button> _buttons;

    /// <summary>
    /// Text as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Text", scrubHtml: true) etc.
    /// </summary>
    public string Text => _item.String("Text", fallback: "");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    /// <remarks>
    /// This hides base property Title.
    /// To access original, convert using AsItem(...) or cast to ITypedItem.
    /// Consider renaming this field in the underlying content-type.
    /// </remarks>
    public new string Title => _item.String("Title", fallback: "");
  }
}