# BMI 計算機

透過使用者輸入四個關鍵資訊 : 性別、年紀、身高、體重，進行 BMI (身體質量指數) 與 BMR（基礎代謝率）計算並提供理想體重建議。


## 核心功能

### 1. 生理指標計算
* **BMI (Body Mass Index)**：根據身高與體重自動判斷體位狀態。
* **BMR (Basal Metabolic Rate)**：採用 Mifflin-St Jeor 公式，依據性別、年齡、身高、體重精確試算。
* **理想體重建議**：以 BMI 22 為基準，自動計算目標體重，並給予增重或減重的具體建議。

### 2. 視覺設計
* **六段體位與顏色**：將體位分為「過輕、正常、過重、輕度肥胖、中度肥胖、重度肥胖」六種等級，分別對應「藍、綠、黃、橘、紅、紫」。
* **視覺回饋**：讓介面背景與結果標籤隨計算結果變動顏色，強化使用者感受。

### 3. 防呆機制
* **資料格式驗證**：有效過濾非數字、負數或零的無效輸入。

### 4. 無滑鼠操作
* **開啟即輸入**：啟動後自動聚焦，手不用離開鍵盤即可開始打字。
* **流暢切換**：全程支援 `Tab` 鍵跳轉、方向鍵選取以及 `Enter` 鍵執行與關閉視窗。


## 使用說明

1.  **資料選擇**：
    * **性別**：預設為男性，可點選或使用鍵盤 **左右方向鍵** 切換。
    * **年齡**：預設為 20 歲，可直接輸入或透過 **上下方向鍵/點擊箭頭** 調整。
      
      <img width="250" alt="螢幕擷取畫面 2026-04-01 222437" src="https://github.com/user-attachments/assets/cb6e075d-25e0-4bd5-a7af-49fe74728b16" />

2.  **數據輸入**：
    * 輸入 **身高 (cm)** 與 **體重 (kg)**。

3.  **欄位跳轉與錯誤提醒**：
    * 按 **`Tab 鍵** 就能在各個格子跟按鈕之間切換。
    * 彈出錯誤警告視窗時，可直接按下 **`Enter` 鍵** 快速關閉彈窗並返回修正。

      <img width="250" alt="螢幕擷取畫面 2026-04-01 222521" src="https://github.com/user-attachments/assets/bf146e58-dcfd-4bd2-a2c4-3afbd2a52ea9" />

4.  **執行計算**：
    * 點擊「計算」按鈕，或在視窗任何位置按下 **`Enter` 鍵**。
      
5.  **讀取報告**：
    * 在分析報告區查看 BMI、BMR、理想體重及健康建議。
    * 以下是6種健康狀態變化：
      
      <img width="110" alt="螢幕擷取畫面 2026-04-01 222557" src="https://github.com/user-attachments/assets/93965f32-76a5-454a-be60-0b22c0807bf6" /> <img width="110" alt="螢幕擷取畫面 2026-04-01 222615" src="https://github.com/user-attachments/assets/a3d19895-5dd0-4ddd-9b2d-46a531870b6d" /> <img width="110" alt="螢幕擷取畫面 2026-04-01 222646" src="https://github.com/user-attachments/assets/c2fd9473-7997-4d8d-82a1-fb2f749b6a8b" /> <img width="110" alt="螢幕擷取畫面 2026-04-01 222703" src="https://github.com/user-attachments/assets/5717115c-17b2-4eb5-9ead-7e9eb74d1afd" /> <img width="110" alt="螢幕擷取畫面 2026-04-01 222722" src="https://github.com/user-attachments/assets/f2dbf225-3c82-412f-8378-4f44b8d6d540" /> <img width="110" alt="螢幕擷取畫面 2026-04-01 222741" src="https://github.com/user-attachments/assets/c26d36c3-3252-4b8a-89b1-9255c356d885" />


## 公式參考

| 項目 | 公式 |
| :--- | :--- |
| **BMI** | $Weight(kg) / Height(m)^2$ |
| **理想體重** | $22 \times Height(m)^2$ |
| **BMR (男)** | $(10 \times weight) + (6.25 \times height) - (5 \times age) + 5$ |
| **BMR (女)** | $(10 \times weight) + (6.25 \times height) - (5 \times age) - 161$ |


## 開發環境

* **開發語言**：C# (.NET Framework)
* **開發工具**：Visual Studio 2022
