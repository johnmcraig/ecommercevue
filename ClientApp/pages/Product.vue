<template>
    <product-details :product="product" />
</template>

<script>
import ProductDetails from '../components/products/Details'

export default {
    name: 'product',
    components: {
        ProductDetails
    },
    data() {
        return {
            product: {
                name: 'Samsung Galaxy S8',
                slug: 'samsung-galaxy-s8',
                thumbnail: 'http://placehold.it/200x300',
                shortDescription: 'Android smartphone with true edge to edge display',
                price: 499.99,
                description: 'Lorem Ipsum'
            }
        }
    }
}
</script>
