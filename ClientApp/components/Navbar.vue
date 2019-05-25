<template>
    <div id="menu">
		<a href="/" class="menuitem">Home</a>
		<a href="#about_content" class="menuitem">About</a>
		<a href="#mission_content" class="menuitem">Mission</a>
		<a href="#contact_content" class="menuitem">Contact</a>
	</div>
</template>

<script>
export default {
    name: 'Navbar'        
}
</script>

<style scoped>
#menu{
	text-align: center;
	color: black;
}
.menuitem{
	padding: 10px;
	cursor: pointer;
	text-decoration: none;
}
.menuitem:hover{
	background-color: black;
	color: white !important;
}
</style>
