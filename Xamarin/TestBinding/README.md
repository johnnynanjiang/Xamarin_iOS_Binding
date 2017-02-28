1. Binding iOS Objective-C libraries with XIB files.

2. Binding static members in Objective-C classes.

3. Soving runtime exceptions, e.g.:
Could not create an native instance of the type 'InfColorPicker.InfColorPickerController': the native class hasn't been loaded.
It is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false.
>>>
Fixed by changing from getter property to method.

4. Binding static methods return null.
5. Got 2 compilation errors with Debug | iPhone.
>>>
Fixed by manually adding libname.linkwith.cs file to the binding library project.
http://stackoverflow.com/questions/22883497/issues-with-objective-c-binding-in-xamarin

6. It is impossible to debug binding libraries.
>>>
https://forums.xamarin.com/discussion/1795/debugging-native-bindings-workflow-question
http://stackoverflow.com/questions/19030908/debugging-native-binding-library
