var BoxViewModel = function()
{
    var self = this;

    self.BoxItems = ko.observableArray();
    

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
}

var BoxItem = function ()
{
    var self = this;

    self.ID = ko.observable();
    self.Description = ko.observable();
    self.Image = ko.observable();
}