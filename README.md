# dispos

ありそうだけど見つからなかったのでサクッと書いてみたWindows用シンプルお会計機。

[カスタマーディスプレイ](https://www.google.com/search?q=%E3%82%AB%E3%82%B9%E3%82%BF%E3%83%9E%E3%83%BC%E3%83%87%E3%82%A3%E3%82%B9%E3%83%97%E3%83%AC%E3%82%A4)を買ってまでやることではないけど、秋葉原で山積みになっているような[小型ディスプレイ](https://www.google.com/search?q=hdmi+OR+rgb+%E5%B0%8F%E5%9E%8B+OR+%E3%83%A2%E3%83%90%E3%82%A4%E3%83%AB+%E3%83%A2%E3%83%8B%E3%82%BF+OR+%E3%83%87%E3%82%A3%E3%82%B9%E3%83%97%E3%83%AC%E3%82%A4&oq=hdmi+OR+rgb+%E5%B0%8F%E5%9E%8B+OR+%E3%83%A2%E3%83%90%E3%82%A4%E3%83%AB+%E3%83%A2%E3%83%8B%E3%82%BF+OR+%E3%83%87%E3%82%A3%E3%82%B9%E3%83%97%E3%83%AC%E3%82%A4)ならば持ってても何かに使えるからそこに表示しちゃいたいという設定。

コスメを施したりしてビルドし直せばフリマとか文化祭とかで使えるかも。

[ビルド済はここ](dist)


## 使い方

### 環境設定
代表的な想定は、PCに小さな外付けディスプレイを1,2個付けたもの。

#### 操作用のディスプレイをメインに指定
設定 -> システム -> ディスプレイ で出てくる1,2と書かれたディスプレイをクリックして選択 -> マルチディスプレイ -> これをメインディスプレイにする

#### 表示用のディスプレイのタスクバーを消す
設定 -> 個人用設定 -> タスクバー -> マルチディスプレイ タスクバーをすべてのディスプレイに表示する -> オフ

さらにメイン以外のディスプレイの解像度を800x600とかの最低のものにする。

### 起動
DisPos.exeを実行。操作パネルの「追加」ボタンを押すと表示パネルが出てくるので、メイン以外のディスプレイに移動して最大化する(しなくてもよい)。
同様に表示パネルを好きなだけ追加して配置。

メインパネルで合計と受け取った額を入力すると、表示パネルでそれが表示される。
Enter とか Shift + Enter とか TAB とか Shift + Tab とかを適当に打ってみると、キーボードだけで便利に使えるかも。

#### メインパネル
![メインパネル](doc/main.png)

#### 表示パネル(全画面表示)
![表示パネル](doc/ext2.png)

#### 表示パネル(ウィンドウ表示)
![表示パネル](doc/ext.png)
