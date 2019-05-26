<template>
    <product-details :product="product" />
</template>

<script>
import ProductDetails from '../components/product/ProductDetails'

export default {
    name: 'product',
    components: {
        ProductDetails
    },
    data() {
        return {
            product: null
        }
    },
    mounted () {
        fetch(`/api/product/${slug}`).then(repsonse => {
            return response.json()
        }).then(product => {
            this.product = product
        })
    }
}
</script>
