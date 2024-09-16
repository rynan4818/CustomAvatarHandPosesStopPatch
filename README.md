# CustomAvatarHandPosesStopPatch

CustomAvatarのPoseManager.InterpolateHandPosesをアバターのCustomKeyEventなどで使えるようにするパッチです。

[CustomKeyEvent](https://github.com/ranmd9a/BSCustomKeyEvents)を使ってコントローラのボタンで手のひらを閉じたり開いたりできます。


これを適用すると、CustomAvatarのフィンガートラッキング機能が停止します。

Pose ManagerでOpen HandsとClosed Handsを設定します

![image](https://user-images.githubusercontent.com/14249877/230777418-1efe465f-30f4-4d0e-ab87-d921929b62db.png)

こんな感じでPoseManager.InterpolateHandPosesを設定して、手のひらの状態を変えられます

![image](https://user-images.githubusercontent.com/14249877/230777470-45d33b41-010f-4338-8e9d-81e8b8719de4.png)
