# OFW - Object Detection Framework

Allows the user to track a colored ball through the camera and then the framework sends the data through UDP connection to the desired endpoint.

## Object Detection Framework

This is a project that I made for my thesis. It was written in C# and uses OpenCV and the OpenCVSharp wrapper for it.

## Usage

Make sure you have a camera connected to your PC. The Framework only runs on Windows.

1. Start the framework (ObejctDetectionFramework folder, either you the pre-compiled exe in the debug directory or use visual studio to run it)
2. Click on create windows button. This will create the checked in windows. You can also check in the Raw checkbox, which is just the raw image output of your camera.
3. Click on start loop button. This starts the main OpenCV loop with the image detection.
4. There is a window with sliders. Use these HSV values to filter out the colors you don't want to track. You can see the unfiltered pixels on the black and white window. The whites are the colors we are tracking and checking. For example for a green ball, you should see whites where your ball is. Try to make this as accurate as you can.
5. You can also tune the sliders on the top left hand corner for a more accurate circle detection. The Framework uses Circular Hough Transform.
6. After everything is set and the ball is getting recognized (there will be a green circle around the ball, not in the RAW window), you can set the endpoint where the data should be sent. If you just want to run it locally, on your machine, leave it as is.
7. Start sending the packets. Framework now up and running and sending the packets with the data about the ball.

7.1 If you want to use the unity example project:
7.2 Open unity, load the example project. (FrameworkTest1 folder)
7.3 Switch to FrameworkTest scene.
7.4 Start the project. It should work. After the first run any consecutive run will freeze. No idea why as of now. Here you will find a GameObject which has a script attached to it that communicates with the framework. You can use this to understand how the communication works.

## Authors

* **Polgardi Marcell** - Nydan

## License

This project is in MIT Software Licensing
