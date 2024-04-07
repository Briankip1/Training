<template>
    <div>
      <NavBar />
      <h1>Welcome to Our Headhunting Agency</h1>
      <p>Discover your potential with us.</p>
    </div>
  </template>
  
  <script>
  import NavBar from '@/components/NavBar.vue'
  
  export default {
    name: 'HomePage',
    components: {
      NavBar
    }
  }
  </script>
  