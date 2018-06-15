#  How to specify the text markup annotation properties when the annotation is being created


<p>This example demonstrates how to specify the text markup annotation properties when the annotation is being created in a document.</p>
<p>To add a markup to text:</p>

* Select the text; 
* Right-click the text and choose <strong>Highlight</strong>, <strong>Strikethrough</strong> or <strong>Underline</strong> item in the invoked context menu. 

![](https://github.com/DevExpress-Examples/how-to-specify-text-markup-annotation-properties-when-the-annotation-is-being-created/blob/18.1.3%2B/Media/MarkupContextMenu.png)

<p>When the text markup annotation is being created in a document, the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.PdfViewer.TextMarkupAnnotationCreating.event">PdfViewer.TextMarkupAnnotationCreating</a> event is raised. In this event, you can specify the annotation properties (for example, the default color used to underline a text using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraPdfViewer.PdfTextMarkupAnnotationCreatingEventArgs.Color.property">PdfTextMarkupAnnotationCreatingEventArgs.Color</a> property).</p> 

<p>You can see properties applied to a newly created annotation in the <strong>Annotation Properties</strong> dialog.</p>

<p>To open this dialog, right-click the annotation and choose the <strong>Properties…</strong> item in the context menu.</p> 

![](https://github.com/DevExpress-Examples/how-to-specify-text-markup-annotation-properties-when-the-annotation-is-being-created/blob/18.1.3%2B/Media/InvokeAnnotationProperties.png)

<p>The <strong>Annotation Properties</strong> dialog is shown below.</p>

![](https://github.com/DevExpress-Examples/how-to-specify-text-markup-annotation-properties-when-the-annotation-is-being-created/blob/18.1.3%2B/Media/AnnotationPropertiesShowResult.png)

<br/>
