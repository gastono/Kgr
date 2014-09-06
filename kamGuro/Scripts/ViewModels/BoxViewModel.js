var BoxViewModel = function()
{
    var self = this;

    self.BoxItems = ko.observableArray();
    self.NewProduct = ko.observable(new BoxItem());  

    self.GetItems = function ()
    {
        $.ajax('/api/ItemApi/GetItems', {
            context: this,
            type: 'GET',
            contentType: 'application/json; charset=utf-8',
            //data: request,
            success: function (data)
            {
                console.log("succesful call");

                $.each(data, function (index, value)
                {
                    var Item = new BoxItem();

                    Item.ID = value.ID;
                    Item.Description = value.Description;
                    Item.Image = value.Image;

                    self.BoxItems.push(Item);
                });
            }           
        });
    };

    self.AddProduct = function ()
    {
        var self = this;
        
        var requestData = ko.toJSON(self.NewProduct);

        $.ajax('/api/ItemApi/AddItem', {
            context: this,
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            data: requestData,
            success: function (data) {
                console.log("succesful insertion");
            }
        });

        self.NewProduct.Description('');
    }   
}

var BoxItem = function ()
{
    var self = this;

    self.ID = ko.observable();
    self.Description = ko.observable();   
}