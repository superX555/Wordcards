# Wordcards
# Wordcards - 智慧單字卡背誦系統

一個基於 C# Windows Forms 開發的單字卡學習應用程式。透過結構化的單字資料載入、字根字源拆解提示，以及多媒體語音播放，幫助語文學習者透過視覺與聽覺雙管齊下，達到高效背單字的記憶效果。

## 🚀 功能特色

* **外部單字庫載入**：啟動時自動讀取 `WordCards.txt` 檔案，支援動態擴充單字庫，並即時於狀態列顯示當前單字總量（如：單字數量：302）。
* **字根字源（Etymology）解析**：詳細呈現單字的組成邏輯（如字根、字首、字尾意涵），用邏輯理解取代死記硬背。
* **多媒體即時發音**：整合 `WindowsMediaPlayer` 元件，點擊單字即可播放標準真人語音檔。
* **全鍵盤快捷操作**：
  * `Enter`：快速跳轉至下一個單字。
  * `Space (空白鍵)`：重複播放當前單字語音。
* **防呆機制**：內建完善的檔案檢查機制，若缺少單字庫或找不到指定音訊檔，系統將自動提示引導。

## 📂 系統架構與物件導向設計

本專案採用物件導向（OOP）架構開發，核心類別說明如下：

1. **`WordItem` (單字實體類別)**
   * 封裝單一單字的屬性：`Word` (單字)、`Phonogram` (音標)、`SoundPath` (語音路徑)、`Explain` (釋義與字根)。
   * 具備 TSV (Tab-Separated Values) 解析建構子，自動將單行文字切轉換為物件。
   * 覆寫 `ToString()` 方法，使 ListBox 控制項能直接優雅地顯示單字文字。

2. **`WordCollection` (單字集合類別)**
   * 繼承自 `Collection<WordItem>`，負責管理整個字庫。
   * 提供 `LoadFromStringArray` 方法，一鍵將讀入的字串陣列批次轉換為 `WordItem` 清單並儲存。

3. **`frmWordCards` (主視窗 UI 邏輯)**
   * 負責控制視窗控制項（ListBox、TextBox、MediaPlayer）的互動、資料綁定與快捷鍵事件處理。

## 🛠️ 資料檔格式規範 (`WordCards.txt`)

單字庫文字檔需放置於編譯輸出目錄（Debug/Release）下，編碼格式為 **UTF-8**。每行代表一個單字，欄位之間請使用 **Tab 鍵 (`\t`)** 進行分隔。

格式如下：
```text
單字 [Tab] 音標 [Tab] 音檔相對路徑 [Tab] 詳細解釋與字根拆解

<img width="633" height="398" alt="image" src="https://github.com/user-attachments/assets/8d15282e-08bd-4eca-8af7-8719996e4c91" />

