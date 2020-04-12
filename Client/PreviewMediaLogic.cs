namespace MyPhotos
{
    internal partial class Form1
    {
        private void SwichPreview(bool value)
        {
            if (value)
            {
                pictureBox1.Show();
                VideoPlayer.Hide();
            }
            else
            {
                pictureBox1.Hide();
                VideoPlayer.Show();
            }
        }

        private void SwichPreviewImport(bool value)
        {
            if (value)
            {
                pictureBox2.Show();
                axWindowsMediaPlayer1.Hide();
            }
            else
            {
                pictureBox2.Hide();
                axWindowsMediaPlayer1.Show();
            }
        }
    }
}