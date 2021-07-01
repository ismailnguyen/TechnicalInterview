
var Order = require('order').Order;
var Logger = require('logger').Logger;

function init () {
    var o = new Order();
    o.id = 42;
    o.articles = [];
    o.articles.push("Choucroute");
    o.articles.push("Artichaud");

    o.prepare();

    if (!o.isValid) {
        throw new Exception("Order is invalid !");
    }
    else {
        var orderLogger = Logger.getLogger("Order", "init");
        orderLogger.error('Order Id : {0}', o.iD);
        orderLogger.error('Saving order with first article {0}', o.articles[0]);

        o.save();
    }
}

exports.init = init;
