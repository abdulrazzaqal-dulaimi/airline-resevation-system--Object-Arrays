Public Class Form1
    Dim BussinessClass(20) As PictureBox
    Dim BussinessBox(20) As RichTextBox
    Dim EconomyClass(80) As PictureBox
    Dim EconomyBox(80) As RichTextBox
    Dim FullSeatImg As String = ".\Full Seat.png"
    Dim EmptySeatImg As String = ".\Empty Seat.png"
    Dim NameBoxes(2) As TextBox
    Dim NameLabel(2) As Label
    Dim Names(2) As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xLocation As Integer = 10
        Dim yLocation As Integer = 10
        Names(0) = "First Name"
        Names(1) = "Last Name"
        For index = 0 To 19
            BussinessClass(index) = New PictureBox() With {
               .ImageLocation = EmptySeatImg,
               .Size = New Size(200, 200),
               .Location = New Point(xLocation, yLocation),
               .Name = "BizPictureBox" + index.ToString(),
               .Visible = True,
               .Enabled = True,
               .Cursor = Cursors.Hand
            }
            Tab1.Controls.Add(BussinessClass(index))
            AddHandler BussinessClass(index).Click, AddressOf PictureBoxClick 'add click event handler to pictureboxes
            BussinessBox(index) = New RichTextBox() With {
                .Size = New Size(200, 150),
                .Location = New Point(xLocation, yLocation + 200),
                .Name = "RichTextBox" + index.ToString(),
                .Visible = True,
                .Enabled = False,
                .Cursor = Cursors.Hand
            }
            Tab1.Controls.Add(BussinessBox(index))
            xLocation += 220
            If (index + 1) Mod 4 = 0 Then
                xLocation = 10
                yLocation += 320
            End If
        Next

        '----------Name Boxes & Labels----------

        NameBoxes(0) = New TextBox With {
                .Name = "TextBox0",
                .Location = New Point(1325, 400),
        .Size = New Drawing.Size(150, 100)
                }
        NameBoxes(1) = New TextBox With {
                    .Name = "TextBox1",
                    .Location = New Point(1325, 450),
            .Size = New Drawing.Size(150, 100)
                    }
        Me.Controls.Add(NameBoxes(0))
        Me.Controls.Add(NameBoxes(1))
        NameLabel(0) = New Label With {
                        .Name = "Label0",
                    .Location = New Point(1200, 400),
                    .Text = Names(0),
                    .Size = New Size(150, 50)
                 }
        NameLabel(1) = New Label With {
                        .Name = "Label1",
                    .Location = New Point(1200, 450),
                    .Text = Names(1),
                    .Size = New Size(150, 50)
                 }
        Me.Controls.Add(NameLabel(0))
        Me.Controls.Add(NameLabel(1))
        xLocation = 10
        yLocation = 10

        '----------Economy Class----------

        For index = 0 To 79
            EconomyClass(index) = New PictureBox() With {
                .ImageLocation = EmptySeatImg,
                .Size = New Size(200, 200),
                .Location = New Point(xLocation, yLocation),
                .Name = "EcoPictureBox" + index.ToString(),
                .Visible = True,
                .Enabled = True,
                .Cursor = Cursors.Hand
            }
            TabPage2.Controls.Add(EconomyClass(index))
            AddHandler EconomyClass(index).Click, AddressOf PictureBoxClick
            EconomyBox(index) = New RichTextBox() With {
                .Size = New Size(200, 150),
                .Location = New Point(xLocation, yLocation + 200),
                .Name = "RichTextBox" + index.ToString(),
                .Visible = True,
                .Enabled = False,
                .Cursor = Cursors.Hand
            }
            TabPage2.Controls.Add(EconomyBox(index))
            xLocation += 220
            If (index + 1) Mod 5 = 0 Then
                xLocation = 10
                yLocation += 320
            End If
        Next
    End Sub
    Private Sub PictureBoxClick(sender As Object, e As EventArgs)
        Dim PictureBoxClicked As PictureBox = sender
        Dim PicBoxNumber As Integer = Convert.ToInt32(PictureBoxClicked.Name.Substring(13))
        Dim BizOrEco As String = (PictureBoxClicked.Name.Substring(0, 3))
        If BizOrEco = "Biz" Then
            If (NameBoxes(0).Text = "" Or NameBoxes(1).Text = "") And BussinessBox(PicBoxNumber).Text = "" Then
                MessageBox.Show($"Please fill in {Names(0)} and {Names(1)}")
                Return
            End If
        End If
        If PictureBoxClicked.ImageLocation = EmptySeatImg And BizOrEco = "Biz" Then
            PictureBoxClicked.ImageLocation = FullSeatImg
            BussinessBox(PicBoxNumber).Text = $"{Names(0)}: {NameBoxes(0).Text} {vbCrLf}{Names(1)}: {NameBoxes(1).Text}"
            MessageBox.Show($"{NameBoxes(0).Text + " " + NameBoxes(1).Text}, your seat has been reserved.")
            Return
        End If
        If BizOrEco = "Eco" Then
            If (NameBoxes(0).Text = "" Or NameBoxes(1).Text = "") And EconomyBox(PicBoxNumber).Text = "" Then
                MessageBox.Show($"Please fill in {Names(0)} and {Names(1)}")
                Return
            End If
        End If
        If PictureBoxClicked.ImageLocation = EmptySeatImg And BizOrEco = "Eco" Then
            PictureBoxClicked.ImageLocation = FullSeatImg
            EconomyBox(PicBoxNumber).Text = $"{Names(0)}: {NameBoxes(0).Text} {vbCrLf}{Names(1)}: {NameBoxes(1).Text}"
            MessageBox.Show($"{NameBoxes(0).Text + " " + NameBoxes(1).Text}, Your seat has been reserved.")
            Return
        End If
        If PictureBoxClicked.ImageLocation = FullSeatImg And BizOrEco = "Biz" Then
            'Ask the user to confirm whether they want to cancel their reservation
            Dim result As DialogResult = MessageBox.Show("Do you want to cancel your reservation?", "Please confirm", MessageBoxButtons.YesNo)
            ' If the user chooses Yes, cancel the reservation and update the text in the corresponding RichTextBox. If they choose no, nothing happens
            If result = DialogResult.Yes Then
                PictureBoxClicked.ImageLocation = EmptySeatImg
                BussinessBox(PicBoxNumber).Text = ""
                MessageBox.Show($"{NameBoxes(0).Text + " " + NameBoxes(1).Text}, your reservation has been cancelled")
            End If
            Return
        End If
        If PictureBoxClicked.ImageLocation = FullSeatImg And BizOrEco = "Eco" Then
            Dim result As DialogResult = MessageBox.Show("Do you want to cancel your reservation?", "Please confirm", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                PictureBoxClicked.ImageLocation = EmptySeatImg
                EconomyBox(PicBoxNumber).Text = ""
                MessageBox.Show($"{NameBoxes(0).Text + " " + NameBoxes(1).Text}, your reservation has been cancelled")
            End If
            Return
        End If
    End Sub
End Class