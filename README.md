# ladybug

Playground for Xamarin.Forms and UI Testing


Simple Shell app used for writing some UITest.

more samples:

//label
bool myLabel = app.Query(e => e.Marked(“MyLabel")).Any();
app.Tap(“MyLabel");

//syncfusion element
switches = app.Query(e => e.Marked("SfSwitch Control. State changed"));
x = (float)switches[c].Rect.CenterX;
y = (float)switches[c].Rect.CenterY;
app.TapCoordinates(x, y);

//swipe gestures
app.SwipeLeftToRight();

//entry
 app.Tap(“MyEntry"); 
 app.EnterText(Constants.Value);
 app.DismissKeyboard();



//inside webview
/*through Safari for iOS 
and through Chrome for Android 
use the browser developer tools 
to visually identify 
the elements inside the DOM.*/

 app.Tap(c => c.WebView().Css("#element"));
 
 
 Feel free to contact me
 @_Codrina_
