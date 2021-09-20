# C# DNN Implementation
DNN Implementation 使用 C Sharp 語言實作 DNN，並透過非同步程式設計技術，將訓練過程即時呈現，可以讓使用者更加了解模型訓練過程以及`loss`、`acc`的變化。

![](https://github.com/Coolshanlan/C-Sharp-DNN-Implementation/blob/master/Demo%20Image/Training_Demo.gif)

在此程式中你可以看到如何自己用`Array`實作簡單的 DNN 以及非同步視覺化，此外，此程式還應用在英文手寫辨識，能讓使用者體驗 DNN 辨識手寫英文的樂趣。
> 目前只支援 ABCDabcd

![](https://github.com/Coolshanlan/C-Sharp-DNN-Implementation/blob/master/Demo%20Image/English_Demo.gif)

## How to Use
![](https://github.com/Coolshanlan/C-Sharp-DNN-Implementation/blob/master/Demo%20Image/GUI_Tutorial.png)

1.	選擇input 資料
2.	讀取之前訓練完成的參數
3.	開始學習，Reset Network 可以重置網路設定，包含層數、神經元數量等
4.	相關訓練參數Times(Epoch)、LR(Learning rate)、alpha(慣性因子)、Hid Layer(Number of Hidden Layer)、Hid num(Number of Neural of Hidden Layer)、Norm(Normalization of Input Ex.Input = Input/Norm)、Gradient lower bound(Early Stopping condition)
5.	保存當前網路參數(鍵結值、偏權值)
6.	英文單字辨識功能
先按Draw 會跳出新畫面，「按住」空白鍵並且用滑鼠滑過方框即可畫出圖形
畫完後直接關閉視窗即可，Input data 會直接顯示在下方textBox裡
此時按下Input 網路就會計算出結果並顯示在11
7.	可以在Correct Ans 欄裡給正確答案(Ex. 0,1,0)並按下Add Data，6裡面的input 會跟7的Ans 組成一筆新資料加進Training Data 裡可以看9下方的DataTable 會多一筆資料
8.	強大神奇按鈕，可以讓網路訓練時同步顯示當前訓練誤差、當前斜率(delta Mse)等資訊，並同時畫出數線圖(13、14)
9.	由於Training Data 可以由6+7新增資料，因此可以用9匯出新的Training Data
10.	當訓練完 10 會顯示出訓練過程中的一些紀錄，紀錄包含Training Loss、Validation Loss、Training Accuracy、Validation Accuracy
11.	按下6的 Input按鈕後，會將網路Output 顯示在11(經過Softmax)
12.	印出鍵結值(And Bias)
13.	Training and Validation Loss Trend chart
14.	Training and Validation Accuracy Trend chart
15.	Classification chart(Only two dimension)
16.	Early Stopping Button 因為我將訓練的執行續與主程式的執行續分開因此可以隨時透過改變參數達到控制學習epoch的功能，所以可以再快要overfitting 時自己按下停止鍵
