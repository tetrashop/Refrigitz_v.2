Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System

Namespace Refrigtz

	Public Class ThingsConverter
		'Initiate Global Variables.
		Public Shared ActOfClickEqualTow As Boolean = False
		Public Convert As Boolean = False
		Public ConvertedToMinister As Boolean = False
		Public ConvertedToBridge As Boolean = False
		Public ConvertedToElefant As Boolean = False
		Public ConvertedToHourse As Boolean = False
		Public Max As Integer
		Public Row As Integer, Column As Integer
		Private color As Color
		Private Order As Integer
		Private Current As Integer = 0
		Public Sub New()
		End Sub
		'Constructor
		Public Sub New(i As Integer, j As Integer, a As Color, Tab As Integer(,), Ord As Integer, TB As Boolean, _
			Cur As Integer)
			'Initite Global Variables with Local Parameter.
			Row = i
			Column = j
			color = a
			Order = Ord


			Current = Cur
		End Sub
		'Convert Operation of Randomly All State Method.
		Public Function ConvertOperation(i As Integer, j As Integer, a As Color, Tab As Integer(,), Ord As Integer, TB As Boolean, _
			Cur As Integer) As Boolean
			'Initiate Global variables with Local One.
			Row = i
			Column = j
			color = a
			Order = Ord
			Current = Cur
			'If Convert is Act and click tow time occured
			If Not Convert AndAlso ActOfClickEqualTow Then
				'Set tow time click unclicked.
				ActOfClickEqualTow = False
				'Convert State Boolean Variable Consideration.
				If color = Color.Gray AndAlso Column = 7 Then
					Convert = True
				End If
				If color = Color.Brown AndAlso Column = 0 Then
					Convert = True
				End If
				'If Converted is Occured the Operation od Set and table reference content occured.
				If Convert Then

					AllDraw.SodierConversionOcuured = True
					'Randomly Number of 4 kind Object.
					Dim Rand As Integer = (New Random()).[Next](0, 4)
					'If Rand is Equaled the Operation will cuased automaticcally Base on Color..
					If Rand = 0 Then
						If color = Color.Gray Then
							AllDraw.MinisterMidle += 1
							AllDraw.MinisterHigh += 1
							Tab(Row, Column) = 5
						ElseIf color = Color.Brown Then
							AllDraw.MinisterHigh += 1
							Tab(Row, Column) = -5
						End If
						ConvertedToMinister = True
					ElseIf Rand = 1 Then
						If color = Color.Gray Then
							AllDraw.BridgeMidle += 1
							AllDraw.BridgeHigh += 1
							Tab(Row, Column) = 4
						ElseIf color = Color.Brown Then
							AllDraw.BridgeHigh += 1
							Tab(Row, Column) = -4
						End If
						ConvertedToBridge = True
					ElseIf Rand = 2 Then
						If color = Color.Gray Then
							AllDraw.HourseMidle += 1
							AllDraw.HourseHight += 1
							Tab(Row, Column) = 3
						ElseIf color = Color.Brown Then
							AllDraw.HourseHight += 1

							Tab(Row, Column) = -3
						End If
						ConvertedToHourse = True
					Else
						If color = Color.Gray Then
							AllDraw.ElefantMidle += 1
							AllDraw.ElefantHigh += 1
							Tab(Row, Column) = 2
						ElseIf color = Color.Brown Then
							AllDraw.ElefantHigh += 1
							Tab(Row, Column) = -2
						End If
						ConvertedToElefant = True
					End If
					Return Convert
				End If
			End If
			'return Convert State.
			Return Convert

		End Function
	End Class
End Namespace