var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('ABP');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);