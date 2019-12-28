<template>
	<b-navbar toggleable="md" type="dark" variant="success">
      <b-container>
        <b-navbar-toggle target="nav_collapse"></b-navbar-toggle>
        <b-navbar-brand to="/">PhoneShop</b-navbar-brand>
        <b-collapse is-nav id="nav_collapse">
          <b-navbar-nav>
            <b-nav-item to="/products">Products</b-nav-item>
          </b-navbar-nav>
        </b-collapse>
      </b-container>
    </b-navbar>
</template>

<script>
export default {
    name: 'Navbar'        
}
</script>

<style scoped>

</style>
