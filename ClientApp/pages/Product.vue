<template>
    <div class="page">
        <product-details :product="product" />
    </div>
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
    beforeRouteEnter(to, from, next) {
        fetch(`/api/products/${to.params.slug}`)
        .then(response => {
        return response.json();
        })
        .then(product => {
        next(vm => vm.setData(product));
        });
    },
    methods: {
        setData(product){
            this.product = product
        }
    }
}
</script>


 