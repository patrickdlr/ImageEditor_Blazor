using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using System;

namespace BlazorServerApp1 {
    public class ImageProcessing_CS : IDisposable {
    //public class ImageProcessing_CS : {
        private Image originalImage;
        private Image editImage;
        private IImageFormat IIF1;

        public ImageProcessing_CS(Image image, IImageFormat imageFormat) {
            this.IIF1 = imageFormat;
            this.originalImage = image;
            this.editImage = image;
        }

		public string getBase64String_function()
		{
			return editImage.ToBase64String(IIF1);
		}

		//public Image GetImage() {
		//    return this.editImage;
		//}

		//public void UpdateImage(Image image) {
		//    this.editImage = image;
		//}

		//public void ResetImage_function() {
		//    editImage = originalImage;
		//}

		public void Dispose()
		{
			originalImage.Dispose();
			editImage.Dispose();
		}
	}


}
