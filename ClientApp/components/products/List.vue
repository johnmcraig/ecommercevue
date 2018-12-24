<template>
    <div class="products">
        <h1>Products</h1>
        <div class="list">
            <div class="item" v-for="product in products" :key="product.slug">
               <h3 @click="select(product)"> {{ product.name}} </h3>
               <img :src="product.thumbnail" :alt="product.name" @click="select(product)" />
               <p @click="select(product)"> {{ product.shortDescription }} </p>
               <p @click="select(product)"> {{ product.price }} </p>
               <hr />
            </div>
            <product-details class="details" v-if="selectedProduct" :product="selectedProduct" />
        </div>
    </div>
</template>

<script>
import ProductDetails from './Details'

export default {
    name: 'product-list',
    components: {
        ProductDetails
    },
    data () {
        return {
            products: [ 
                    {
                        name: "Samsung Galaxy 8",
                        slug: "samsung-galaxy-s8",
                        thumbnail: "http://placehold.it/200x300",
                        shortDescription: "Samsung Galaxy S8 Android smartphone",
                        price: 499.99,
                        description: "Lorem Ipsum"
                    }
            ],
            selectedProduct: null
        }
    },
    methods: {
        select(product) {
            this.selectedProduct = product;
        }
    }
}
</script>

<style>

* {
    box-sizing: border-box !important;
}

.products {
    padding: 20px;
    max-width: 1200px;
    margin: 0 auto;
}

.list .details {
    width: 50%;
    float: left;
}

.list .item {
    width: 50%;
    float: left;
    padding: 20px 10px 20px;
}

.list img, .list h3, .list p {
    cursor: pointer;
}

.list img {
    width: 100px;
}

</style>


