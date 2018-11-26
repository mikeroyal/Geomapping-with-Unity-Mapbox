# Geocoding/Mapping with Unity Mapbox
![mapunity](https://user-images.githubusercontent.com/18353476/40161818-bf50210c-5966-11e8-8ded-291f142d960e.png)

Create and Style the tile layers of your map(2d or 3d) for any augmented reality and virtual reality applications.

![map style](https://user-images.githubusercontent.com/18353476/28952342-5d2ab572-7885-11e7-8030-2c1017f9172a.PNG)
![map4](https://user-images.githubusercontent.com/18353476/28952494-6aef7c8c-7886-11e7-98ff-167490a6623b.gif)
![sf map](https://user-images.githubusercontent.com/18353476/29289910-273357a0-80f3-11e7-93ba-9ba40aae97be.gif)

# Vulkan Support 
[Vulkan is a new generation graphics and compute API](https://www.lunarg.com/vulkan-api-3d-graphics/) that provides high-efficiency, cross-platform access to modern GPUs in both PCs and on mobile platforms. Android Nougat version 7.0 from Google brings official support for the Vulkan API.The main benefit of Vulkan over older mobile rendering APIs such as OpenGL ES 3.x is speed. Vulkan is designed to take advantage of multiple CPU cores by allowing the application to build command lists in multiple threads in parallel. This allows the application to take advantage of all of the CPU cores on the device, improving performance.

To enable Vulkan support, open “Player Settings”, go to the “Other Settings” pane and clear the “Auto Graphics API” checkbox. You are presented with an ordered list of graphics APIs to choose from. If Vulkan is not on that list, click the ‘+’ sign at the bottom of the list to add it. Then drag Vulkan to be the first item on the list so that it’ll be used whenever supported, and you’re done! All your existing shaders will get translated to Vulkan SPIR-V.
![vulkan](https://user-images.githubusercontent.com/18353476/28993201-7543d586-7965-11e7-8e9c-f93b7079e2bf.PNG)

[MoltenVK](https://github.com/KhronosGroup/MoltenVK/tree/8d9ee9b5184ab2df1f339d8413475b8168b868b3) is an implementation of the high-performance, industry-standard Vulkan graphics and compute API, that runs on Apple's Metal graphics framework, bringing Vulkan to iOS and macOS.

# Requirements and installation
![mapbox-unity](https://user-images.githubusercontent.com/18353476/28955677-13871fce-789d-11e7-8899-4f1917ba6336.PNG)

[Visual Studio 2017](https://www.visualstudio.com/)

[Unity 2017.4 or later](https://unity3d.com/)

[Unity 2018.2.4f1 for Linux](https://beta.unity3d.com/download/fe703c5165de/public_download.html)

[Mapbox Studio](https://www.mapbox.com/mapbox-studio/)

[macOS Mapbox SDK](https://mapbox.github.io/mapbox-gl-native/macos/0.9.0/)

Linux Coming soon.

Getting started: https://www.mapbox.com/mapbox-unity-sdk/docs/00-getting-started.html

Configuring your API token: https://www.mapbox.com/mapbox-unity-sdk/docs/01-mapbox-api-token.html

Known Issues: https://www.mapbox.com/mapbox-unity-sdk/docs/02-known-issues.html

Built-in Examples: https://www.mapbox.com/mapbox-unity-sdk/docs/03-examples.html

Attribution: https://www.mapbox.com/mapbox-unity-sdk/docs/04-attribution.html

Mapbox Unity SDK API: https://www.mapbox.com/mapbox-unity-sdk/api/

Mapbox Maps API: https://www.mapbox.com/api-documentation/#maps 

Mapbox Map Matching API: https://www.mapbox.com/api-documentation/#map-matching

Mapbox Optimization API: https://www.mapbox.com/api-documentation/#optimization

Navigation SDKs for iOS and Android: https://www.mapbox.com/navigation-sdk/

Vision SDK for Automotive artificial intelligence: https://www.mapbox.com/vision/

Changelog: https://www.mapbox.com/mapbox-unity-sdk/docs/05-changelog.html

IMPORTANT: If you intend to deploay for Android, please set your minimum version to 15 in PlayerSettings.
For iOS, please set your minimum version to 8.

# Unity3d(Building for Android and iOS)
[Get Unity Here](https://unity3d.com/)

[Unity for VR and AR](https://unity3d.com/unity/features/multiplatform/vr-ar)

[Game Development with Unity for iOS and Android devices.pdf](https://github.com/Mikerr1111/Marauder-Wolves/files/1216274/Game.Development.with.Unity.for.iOS.and.Android.devices.pdf)

![unity-native-plugins-intro-sdk-architecture](https://user-images.githubusercontent.com/18353476/29191030-200f304a-7dd1-11e7-99c0-96915e796721.png)

![build_to_android_5](https://user-images.githubusercontent.com/18353476/27527819-55779986-5a02-11e7-96cc-bfaeb3a1b5f6.png)

# Getting started with Android development
[Android Development](https://docs.unity3d.com/Manual/android-GettingStarted.html)

[Android Studio 3.0](https://developer.android.com/studio/index.html)

[Android Studio User Guide(Windows, Mac, and Linux)](https://developer.android.com/studio/intro/index.html)

# iOS Build Settings
[Unity v2017.3 or later](https://unity3d.com/)

Requires iOS 10 or later

[Requires XCode 9.3 or later](https://developer.apple.com/xcode/)

Requires iOS device(iPhone 6S or later, iPad (2016) or later)

In Bulid setting make sure to checkmark the boxes for Symlink Unity libraries and Development Build.
![switch_platform-ios](https://user-images.githubusercontent.com/18353476/29189508-afd6ff06-7dcb-11e7-84e3-0b45e50e36ca.png)
