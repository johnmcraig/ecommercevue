<template>
    <div>
        <h1>Welcome to Hands on Vue.js with ASP.NET Core 2.2!</h1>
        <p>The time now is: {{ time }}</p>
        
        <product-list />
    </div>
</template>

<script>
import ProductList from './catalogue/ProductList'

export default {
    name: 'Home',
    components: {
        ProductList: ProductList
    },
    data () {
        return {
            time: new Date().toString()
        }
    }
}
</script>

<style scoped>

</style>