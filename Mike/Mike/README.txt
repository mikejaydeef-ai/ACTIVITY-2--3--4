HOW TO OPEN

1. Extract this zip to a new folder (right-click -> Extract All).
   Tip: use a folder like C:\Projects instead of Downloads.
2. Double-click Login_Sign-in.sln (opens in Visual Studio).
3. Wait for the NuGet restore to finish, then press F5 to run.

DATABASE
  database.accdb is included next to Login_Sign-in.csproj and is copied
  to the output folder automatically on every build. The app also accepts
  datavase.accdb or LGSI.accdb if you prefer to use one of those names.
  It needs the Microsoft Access Database Engine (ACE OLEDB 12.0) installed,
  in the same bitness as the app (64-bit).

IF THE BUILD SAYS "file is locked" / "being used by another process"
  The app is still running. Close its window, or press Shift+F5 in
  Visual Studio, or run:  taskkill /IM Login_Sign-in.exe /F
  Use F5 (not Ctrl+F5) so the Stop button works.

IF VISUAL STUDIO CAN'T FIND THE .NET VERSION
  Open your OLD project's .csproj, copy its <TargetFramework> value
  (for example net9.0-windows), and paste it into the same line in
  Login_Sign-in.csproj. If it was net9.0-windows, also change the
  System.Data.OleDb version from 8.0.1 to 9.0.0.

BEHAVIOR
  Logout on the dashboard returns to the login screen.
  Closing the dashboard with the X closes the whole app.

FILE NAMES
  LGF = login          SUF = sign up        FPF = forgot password
  DBF = dashboard      PDb = product data   Thm = colors and styling
