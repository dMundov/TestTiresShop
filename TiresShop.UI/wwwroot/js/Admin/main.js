var app = new Vue({
    el: "#app",
    data: {
        loading: false,
        productModel: {
            name: "ProductName",
            description: "ProductDescription",
            value: 2.59
        },
        products:[],
    },
    methods: {
        
        getProducts() {
            this.loading = true;
            axios.get('/Admin/allProducts')
                .then(res => {
                    console.log(res);
                    this.products = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        createProduct() {
            this.loading = true;
            axios.post('/Admin/createProduct', this.productModel)
                .then(res => {
                    console.log(res);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        }
    }
});