class Order {
    id;
    articles;
    isValid;

    prepare () {
        for (var i=0; i < this.articles.length; i++) {
            if (this.articles[i].toUpperCase() == "CHOUCROUTE") {
               this.articles = null;
               this.isValid = false;
            }
        }
        
        this.isValid = true;
    }

    save () {
        // TODO: implementation of save
    }
}

exports.Order = Order;
