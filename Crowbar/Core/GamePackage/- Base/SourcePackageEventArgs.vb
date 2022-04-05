﻿Public Class SourcePackageEventArgs
	Inherits System.EventArgs

	'Public Sub New(ByVal entry As BasePackageDirectoryEntry, ByVal entryDataOutputText As String)
	'	MyBase.New()

	'	Me.theEntry = entry
	'	Me.theEntryDataOutputText = entryDataOutputText
	'End Sub
	Public Sub New(ByVal entry As SourcePackageDirectoryEntry)
		MyBase.New()

		Me.theEntry = entry
	End Sub

	Public ReadOnly Property Entry As SourcePackageDirectoryEntry
		Get
			Return Me.theEntry
		End Get
	End Property

	'Public Property EntryDataOutputText As String
	'	Get
	'		Return Me.theEntryDataOutputText
	'	End Get
	'	Set(value As String)
	'		Me.theEntryDataOutputText = value
	'	End Set
	'End Property

	Private theEntry As SourcePackageDirectoryEntry
	'Private theEntryDataOutputText As String

End Class
