# Open-AutoGLM_GUI

[Readme in English](README_en.md)

## 项目介绍

Open-AutoGLM_GUI 是一个基于 [Open-AutoGLM ](https://github.com/zai-org/Open-AutoGLM) 的图形界面（GUI）。以下说明基本上是从官方 Github 仓库中摘取出一些本项目必要的内容。如需获取更多关于 Open-AutoGLM 的信息，请访问 [Open-AutoGLM ](https://github.com/zai-org/Open-AutoGLM)

## 环境配置

### 1. Python 环境

推荐使用 Python 3.10 或更高版本。

### 2. 设备调试工具

根据你的设备类型选择合适的工具：

#### Android 设备 - 使用 ADB

1. 下载官方 ADB [安装包](https://developer.android.com/tools/releases/platform-tools)，并解压到自定义路径

2. 配置环境变量

   将 adb.exe 所在的目录添加到 **`系统变量 > Path`**。打开环境变量的方法：`设置 > 系统 > 关于 > 高级系统设置 > 环境变量`

#### HarmonyOS 设备

等待适配

### 3. Android 7.0+ 或 HarmonyOS 设备，并启用 `开发者模式` 和 `USB 调试`

1. 启用开发者模式：通常的方法是进入 `设置 > 关于手机 > 版本号`，连续点击大约 10 次，直到弹出“已启用开发者模式”的提示。不同手机可能略有差异，如果找不到可以自行搜索教程。
2. 启用 USB 调试：启用开发者模式后，进入 `设置 > 开发者选项 > USB 调试` 并开启
3. 某些设备在设置开发者选项后可能需要重启才能生效。你可以通过使用 USB 数据线将手机连接到电脑，并运行 `adb devices` 来测试是否成功。如果没有显示设备信息，则说明连接失败。

**请仔细检查相关权限**

![Permissions](OpenAutoGLM_GUI/Resources/screenshot-20251209-181423.png)

### 4. 安装 ADB Keyboard（仅 Android 设备必需，用于文本输入）

如果你使用的是 Android 设备：

下载 [安装包](https://github.com/senzhk/ADBKeyBoard/blob/master/ADBKeyboard.apk) 并安装到对应的 Android 设备上。
 注意：安装完成后，需要在 `设置 > 输入法` 或 `设置 > 键盘列表` 中启用 `ADB Keyboard` 才能正常使用。（或者使用命令 `adb shell ime enable com.android.adbkeyboard/.AdbIME`，[使用方法](https://github.com/senzhk/ADBKeyBoard/blob/master/README.md#how-to-use)）

## 部署准备

### 1. 安装依赖

下载 [Open-AutoGLM ](https://github.com/zai-org/Open-AutoGLM)，并解压到自定义路径。

在main.py目录下打开cmd

```
pip install -r requirements.txt 
pip install -e .
```

### 2. 配置 ADB 或 HDC

***注意：你可以按照以下步骤在 cmd 中检查 adb.exe 是否正常工作，或者直接在 Auto-GLM GUI.exe 中检查***

#### Android 设备

1. 通过 USB 数据线

   确保你的 **USB 数据线支持数据传输**，而不是充电线。

   确保已安装 ADB，并通过 **USB 数据线** 连接设备：

   ```
   # 检查已连接的设备
   adb devices
   
   # 输出应显示你的设备，例如：
   # List of devices attached
   # emulator-5554   device
   ```

2. 通过 WiFi / 网络

   你也可以通过 WiFi / 网络连接设备。

   确保手机和电脑在同一 WiFi 网络下，进入 `设置 > 开发者选项 > 无线调试`，如下所示：

   ![Permission](OpenAutoGLM_GUI/Resources/setting.png)

   在电脑上使用标准 ADB 命令：

   ```
   # Android 设备 - 通过 WiFi 连接，将 IP 地址和端口替换为手机上显示的内容
   adb connect 192.168.1.100:5555
   
   # 验证连接
   adb devices
   # 应显示：192.168.1.100:5555    device
   ```

### 3. 启动模型服务

你可以选择自行部署模型服务，或者使用第三方模型服务。

#### 方案 A：使用第三方模型服务

如果你不想自己部署模型，可以使用以下已经部署好模型的第三方服务：

**1. 智谱 BigModel**

- 文档：https://docs.bigmodel.cn/cn/api/introduction

- OpenAutoGLM_GUI.exe 中要使用到的参数：

  url: ` https://open.bigmodel.cn/api/paas/v4`

  model: `autoglm-phone`

  API Key：在智谱平台申请你的 API Key

**2. ModelScope(魔搭社区)**

- 文档：https://modelscope.cn/models/ZhipuAI/AutoGLM-Phone-9B

  url: `https://api-inference.modelscope.cn/v1`

  model: `ZhipuAI/AutoGLM-Phone-9B`

  API Key：在 ModelScope 平台申请你的 API Key

#### 方案 B：自行部署模型

详细步骤请访问：[https://github.com/zai-org/Open-AutoGLM?tab=readme-ov-file#%E9%80%89%E9%A1%B9-b-%E8%87%AA%E8%A1%8C%E9%83%A8%E7%BD%B2%E6%A8%A1%E5%9E%8B](https://github.com/zai-org/Open-AutoGLM?tab=readme-ov-file#选项-b-自行部署模型)

如果你已经成功部署，只需要将 url 改为你自己的地址，例如 `http://localhost:8000/v1`，将 model 改为你的模型名称，并记得勾选 `useLocalModel`