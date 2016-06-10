
(function () {
    'use strict';
  var app = WinJS.Application;
  var activation = Windows.ApplicationModel.Activation;
  app.onactivated = function (args) {
    if (args.detail.kind === activation.ActivationKind.launch) {
      if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
        // TODO: このアプリケーションは新しく起動しました。ここでアプリケーションを初期化します。
      } else {
        // TODO: このアプリケーションは、中断状態から再アクティブ化されました。
        // ここでアプリケーションの状態を復元します。
      }
      args.setPromise(WinJS.UI.processAll().then(function() {
        // TODO: コードはここに挿入。
      }));

      //ボタンのイベントリスナーを登録
      button1.addEventListener("click",onButtonClick);
    }
  };
  app.oncheckpoint = function (args) {
    // TODO: このアプリケーションは中断しようとしています。ここで中断中に維持する必要のある状態を保存します。
    // WinJS.Application.sessionState オブジェクトを使用している可能性があります。このオブジェクトは、中断の間自動的に保存され、復元されます。
    //ご使用のアプリケーションを中断する前に非同期の操作を完了する必要がある場合は、args.setPromise() を呼び出してください。
  };
  app.start();
}());

//ボタンのクリックイベントを受け取る関数
function onButtonClick(event) {
    text1.textContent = "Hello,World!";

    //トースト通知を行うためのコード
    //(WindowsのAPIを呼び出すデモ用)
    var notification = Windows.UI.Notifications;
    var notificationManager = Windows.UI.Notifications.ToastNotificationManager;
    var template = notification.ToastTemplateType.toastText01;
    var toastXml = notificationManager.getTemplateContent(template);
    var toastTextElements = toastXml.getElementsByTagName("text");
    toastTextElements[0].appendChild(toastXml.createTextNode("Hello World!"));
    var toast = new notification.ToastNotification(toastXml);
    notificationManager.createToastNotifier().show(toast);
}
