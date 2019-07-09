﻿Public Class BaseUserControl

	Public Sub New()

		' This should allow Forms that inherit from this class and their widgets to use the system font instead of Visual Studio's default of Microsoft Sans Serif.
		'TEST: See if this prevents the overlapping or larger text on Chinese Windows.
		Me.Font = New Font(SystemFonts.MessageBoxFont.Name, 8.25)

		' This call is required by the designer.
		InitializeComponent()
	End Sub

End Class
