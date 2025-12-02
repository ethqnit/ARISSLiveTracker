# ARISSLiveTracker

#This is an Old Release that I had using various Unity Provided Packages. Contains many modified assets and script to extract data using Get. This was an attempt to create a target on a 3D world from your GPS position looking up to the Satellite. 
Tried a combination of Gyrosopes assets and Virtual Reality assets and taking Json based corrdiates to update tracker. (It did not work that well however, the concept is here and there are now many apps that perfected this now.
#This is done Using Unity3D Game Development Engine. 

<img src="https://img.shields.io/badge/Status-Archived-red?style=for-the-badge" alt="Project Status"> <img src="https://img.shields.io/badge/Unity-2019%20LTS-000000.svg?style=for-the-badge&logo=unity" alt="Unity Version"> <img src="https://img.shields.io/badge/Platform-Android%20%7C%20iOS-3DDC84?style=for-the-badge&logo=android" alt="Platforms">

# 🛰️ AR ISS Live Tracker (Legacy)

**Real-time International Space Station tracking in Augmented Reality**  
An experimental Unity project that attempts to point your phone at the exact spot in the sky where the ISS is currently passing over your head — using your GPS, device sensors, and live orbital data.

<div align="center">
  <img src="./.github/iss-preview.gif" width="600" alt="AR ISS Tracker Preview"/>
  <br><br>
  <i>Early prototype in action — pointing the device skyward to "see" the ISS in real time</i>
</div>

<br>

## 🌟 Features (2019–2020 era)

- Live ISS position via public TLE/NASA APIs (JSON)
- GPS-based user location tracking
- Device gyroscope + compass fusion for sky pointing
- 3D arrow/target overlay in AR space
- Experimental VR/AR hybrid camera controls
- Custom modified Unity assets & scripts

> **Note**: This was an early proof-of-concept. Accuracy was limited by sensor fusion and mobile hardware of the time. Modern apps (like NASA's Spot the Station AR or Star Walk) have perfected this concept.

<br>

## 🛠️ Built With

- **Unity 2019 LTS** (with AR Foundation attempts + legacy XR packages)
- Custom JSON parsing for satellite coordinate data
- Modified third-party gyroscope & orientation assets
- Pure C# scripting (pre-Jobs System, pre-DOTS era)

<br>

## 📱 Demo / Screenshots

| Sky Tracking View | Debug Overlay | AR Target Lock |
|-------------------|---------------|----------------|
| ![1](./.github/screenshot1.jpg) | ![2](./.github/screenshot2.jpg) | ![3](./.github/screenshot3.jpg) |

*(Add your actual screenshots to `.github/` folder)*

<br>

## ❤️ Why I'm archiving this

This was one of my first deep dives into real-time geospatial AR. While it never reached "perfect" tracking, it taught me an insane amount about:
- Sensor fusion on mobile
- Coordinate system conversions (ECEF → Unity world space)
- Working with live astronomical data
- The limits of consumer phone gyroscopes

Today (2025), this concept is beautifully solved by many apps — but this repo remains as a time capsule of that exciting experimentation phase.

<br>

## 🔗 Useful Links

- NASA ISS Live Data API: https://wheretheiss.at
- Open-Notify API (used in project): http://api.open-notify.org
- Modern successor apps: Star Walk 2, NASA App, SkyView

<br>

## ⭐ Star History

[![Star History Chart](https://api.star-history.com/svg?repos=yourusername/ARISSLiveTracker&type=Date)](https://star-history.com/#yourusername/ARISSLiveTracker&Date)

<br>

<footer align="center">
  <sub>Made with ❤️ and a lot of late-night debugging sessions</sub><br>
  <sub>Feel free to fork, learn from, or laugh at my old code 😄</sub>
</footer>
