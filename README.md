# Strange File Picker Behvior In Maui Blazor App
1. We can open file picker from a button outside BlazorWebView i.e. "Open from XAML" button flakily and once most of the times.

   After that web console starts to print the following message:
![image](https://github.com/Take-A-Byte/StrangeFilePickerBehviorInMauiBlazorApp/assets/29909785/08d94138-4057-4b47-b0d1-89a4008ad73b)

3. Whereas, if I use the button defined in Blazor i.e. "Open from Blazor" button, I can open the file picker as many times as I want.
