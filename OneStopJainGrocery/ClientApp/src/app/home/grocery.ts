export class Grocery{
    public id			: number;
    public productname 	: string;
    public productimage : string;
    public producturl 	: string;
    public categories 	: string;
    public dietType 	: string;
    public country 		: string;


    constructor(Id: number,Productname: string, Productimage : string, Producturl : string, Categories : string, DietType : string, Country : string ){
        this.id=Id;
        this.productname=Productname;
        this.productimage= Productimage;
        this.producturl = Producturl;
        this.categories = Categories;
        this.dietType = DietType;
        this.country = Country;
    }

    Grocery(){

    }
    
}