# TypingGameSystemForUnity
- Typingゲームをunityで作るためのモジュールです.
- [こちら](http://tuys.jimdo.com/%E8%A7%A3%E8%AA%AC/%E3%82%BF%E3%82%A4%E3%83%94%E3%83%B3%E3%82%B0%E3%82%B2%E3%83%BC%E3%83%A0%E3%82%A2%E3%83%AB%E3%82%B4%E3%83%AA%E3%82%BA%E3%83%A0/)のサイトを参考に作成しました．

## 注意
バグがある可能性，対応していない文字がある可能性があります．フィードバックを待っています．

## 構成
- TypingSystem.cs
  - 本体です．unityのスクリプトとしてだけでなく，他のシステムにも組み込めるようスタンドアロンで作っています．
-  sample 
  - サンプルシーンと、そこで必要なものを入れています。

## TypingSystemクラス仕様
#### 用語
「タイピング」という文字を入力するとして，
- String
  - 文字列そのもののことです．この場合「タイピング」です．
- Key
  - ローマ字に直したときに入力するアルファベットのことです．この場合「taipingu」がKeyの候補の一つになります．

### メソッド
| メソッド名 | 引数 | 説明 | 返り値|
|:-----------|:---- |:------------|:--|
| SetInputString | inputString(string)  | 引数に取った文字列を入力すべき文字列とし，初期化を行います．||
| InputKey   | inputKey(string) | 引数に取った文字列(key)が，入力すべきkeyかどうかを判定し，処理を行います． |入力に成功すれば1, 失敗すれば0．|
| isEnded   || 入力すべき文字列がすべて入力完了したかどうかを返します．終了判定に使えます． | 成功していればtrue, してなければfalse |

> その他Get系

> > GetInputString : 入力すべきすべての文字列を返します．SetInputStringでセットした値です．

> > GetInputedString : 入力完了した文字列をすべて返します．

> > GetRestString : 残りの入力すべき文字列を返します．

> > GetInputedKey : 入力完了したアルファベット(Key)を返します．

> > GetRestKey : 残りの入力すべきアルファベット(Key)の候補を一つ返します．

> 例えば「ドラえもん」という文字列に対して「dorae」まで入力完了しているとき，

> > GetInputString : ドラえもん

> > GetInputedString : ドラえ

> > GetRestString : もん

> > GetInputedKey : dorae

> > GetRestKey : monn

> とそれぞれ返します．

> また，Get◯◯String系は引数に isOrigin と isKatakana というブール値を取れます．

> isOriginはtureにすると，元の文字列そのままをとってきます．デフォルトでtrueです．

> isOriginがfalseのときのみisKatakanaは評価され，trueの場合はカタカナで，falseの場合はひらがなで文字列を返します.isKatakanaはデフォルトでfalseです．

> > GetInputString(true) : ドラえもん

> > GetInputString(false, false) : どらえもん

> > GetInputString(false, true) : ドラエモン
