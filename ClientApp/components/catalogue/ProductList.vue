<template>
  <div class="products">
    <b-container>
      <h1 class="mt-4 mb-4">Products</h1>
      <b-row>
        <b-col class="mb-4" sm="6" v-for="product in products" :key="product.id">
          <b-media class="product">
            <img slot="aside" :src="product.thumbnail" :alt="product.name" @click="view(product)">
            <h2 class="mt-2" @click="view(product)">{{ product.name }}</h2>
            <p class="mt-4 mb-4">{{ product.shortDescription }}</p>
            <p class="mt-4 mb-4">{{ product.price }}</p>
            <b-button variant="primary">Add to cart</b-button>
          </b-media>
        </b-col>
      </b-row>
    </b-container>
  </div>
</template>

<script>
export default {
  name: 'product-list',
  data () {
    return {
      products: []
    }
  },
  selectedProduct: null,
  methods: {
    view (product) {
      this.$router.push(`/products/${product.slug}`)
    }
  },
  mounted () {
    fetch('api/products')
      .then(response => {
        return response.json()
      })
      .then(products => {
        this.products = products
      })
  }
}
</script>

<style>
.product {
  border: 3px solid #eee;
}
img, h2 {
    cursor: pointer;
}
</style>
