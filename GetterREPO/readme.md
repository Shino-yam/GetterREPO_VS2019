# ニュース収集プログラム 「GetterREPO」

## 完成度
2022/01/30時点の完成度：約60%
### 未実装項目
* RSS取得時、サーバからの「差分取得」ができていない
* ニュースの保存機能が未実装
* ニュースの検索機能が未実装
* メイン画面左側、ニュースリストを選択した際、マウスホイールのスクロールで組み込みブラウザのスクロールができていない
* 展開メニューの機能が未実装
    * ニックネームの変更
    * ファイル保存パスの変更
### 実装済項目
* 新規ニックネーム，新規ニュース保存場所の設定
* ニックネームの登録機能
* サーバからのRSSリストダウンロード
* メイン画面左側、ニュースリストを選択することで、組み込みブラウザでニュースを表示する

## 反省点
* 取り組める時間が圧倒的に不足でした。作りこみが思うところまで進められなかったのは残念でした。
* 「ニックネーム」の登録について、構想当初は活用する目的が存在したが、現時点では意味の無い登録項目になってしまっています。
* コーディング後のテストも不充分な状態で、特に組み込みブラウザのセキュリティについては課題が残ります。
    * RSSで読み込んだドメインから、別のドメインへは遷移できないようにするなどの対策が必要だったかもしれない。
* 組み込みブラウザ、最新版はwebView2ですが、EverGreenライブラリのインストールが必要になることから、webView(旧版)を採用しましたが、コーディングの自由度やセキュリティ面でどうだったかといえば疑問は残ります。

## 今後について
* 取り組みに使える時間があるなら、このプログラムは、当初考えていたところまでは作りこみたい。


