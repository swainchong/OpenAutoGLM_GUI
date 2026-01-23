# Open-AutoGLM_GUI

## Project Introduce

Open-AutoGLM_GUI is a GUI based on [Open-AutoGLM ](https://github.com/zai-org/Open-AutoGLM).  The instruction below is basically abstracted from Official Github repository that is necessary for this project. Visit [Open-AutoGLM ](https://github.com/zai-org/Open-AutoGLM) to get more information about Open-AutoGLM.

## Environment Setup

### 1. Python Environment

Python 3.10 or higher is recommended.

### 2. Device Debug Tools

Choose the appropriate tool based on your device type:

#### For Android Devices - Using ADB

1. Download the official ADB [installation package](https://developer.android.com/tools/releases/platform-tools) and extract it to a custom path
2. Configure environment variables

#### For HarmonyOS Devices

Waiting for adaption

### 3. Android 7.0+ or HarmonyOS Device with `Developer Mode` and `USB Debugging` Enabled

1. Enable Developer Mode: The typical method is to find `Settings > About Phone > Build Number` and tap it rapidly about 10 times until a popup shows "Developer mode has been enabled." This may vary slightly between phones; search online for tutorials if you can't find it.
2. Enable USB Debugging: After enabling Developer Mode, go to `Settings > Developer Options > USB Debugging` and enable it
3. Some devices may require a restart after setting developer options for them to take effect. You can test by connecting your phone to your computer via USB cable and running `adb devices` to see if device information appears. If not, the connection has failed.

**Please carefully check the relevant permissions**

![Permissions](OpenAutoGLM_GUI/Resources/screenshot-20251210-120416.png)

### 4. Install ADB Keyboard (Required for Android Devices Only, for Text Input)

If you are using an Android device:

Download the [installation package](https://github.com/senzhk/ADBKeyBoard/blob/master/ADBKeyboard.apk) and install it on the corresponding Android device.
Note: After installation, you need to enable `ADB Keyboard` in `Settings > Input Method` or `Settings > Keyboard List` for it to work.(or use command `adb shell ime enable com.android.adbkeyboard/.AdbIME`[How-to-use](https://github.com/senzhk/ADBKeyBoard/blob/master/README.md#how-to-use))

## Deployment Preparation

### 1. Install Dependencies

Download [Open-AutoGLM ](https://github.com/zai-org/Open-AutoGLM), extract to a custom path.

```bash
pip install -r requirements.txt 
pip install -e .
```

### 2. Configure ADB or HDC

***Note: You can check whether adb.exe is working following the below steps, or you can just check in Auto-GLM GUI.exe*** 

Before running on cmd, you should add the directory where adb.exe located into the **`System Path`**: Setting > 

#### For Android Devices

1. Via USB cable

   Make sure your **USB cable supports data transfer**, not just charging.

   Ensure ADB is installed and connect the device via **USB cable**:

   ```bash
   # Check connected devices
   adb devices
   
   # Output should show your device, e.g.:
   # List of devices attached
   # emulator-5554   device
   ```

2. Via WiFi/network

   You can also connect your devices via WiFi/network

   Ensure the phone and computer are on the same WiFi network, go to `Settings > Developer Options > Wireless Debugging` as shown:

   ![Permission](OpenAutoGLM_GUI\Resources\screenshot-20251210-120630.png)

   Use Standard ADB Commands on Computer

   ```bash
   # Android device - Connect via WiFi, replace with the IP address and port shown on your phone
   adb connect 192.168.1.100:5555
   
   # Verify connection
   adb devices
   # Should show: 192.168.1.100:5555    device
   ```


### 3. Start Model Service

