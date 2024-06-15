<template>
  <div class="max-w-md mx-auto mt-10">
    <h2 class="text-2xl font-semibold mb-4">Register</h2>
    <form @submit.prevent="registerUser">
      <div class="mb-4">
        <label for="first-name" class="block text-sm font-medium text-gray-700">First name</label>
        <input type="text" v-model="firstName" id="first-name" class="mt-1 block w-full border border-gray-300 rounded-md shadow-sm py-2 px-3 focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm" required>
      </div>
      <div class="mb-4">
        <label for="last-name" class="block text-sm font-medium text-gray-700">Last name</label>
        <input type="text" v-model="lastName" id="last-name" class="mt-1 block w-full border border-gray-300 rounded-md shadow-sm py-2 px-3 focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm" required>
      </div>
      <div class="mb-4">
        <label for="username" class="block text-sm font-medium text-gray-700">Username</label>
        <input type="text" v-model="username" id="username" class="mt-1 block w-full border border-gray-300 rounded-md shadow-sm py-2 px-3 focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm" required>
      </div>
      <div class="mb-4">
        <label for="password" class="block text-sm font-medium text-gray-700">Password</label>
        <input type="password" v-model="password" id="password" class="mt-1 block w-full border border-gray-300 rounded-md shadow-sm py-2 px-3 focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm" required>
      </div>
      <div class="mb-4">
        <label for="phone-number" class="block text-sm font-medium text-gray-700">Phone Number</label>
        <input type="text" v-model="phoneNumber" id="phone-number" class="mt-1 block w-full border border-gray-300 rounded-md shadow-sm py-2 px-3 focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm" required>
      </div>
      <div class="mb-4">
        <label for="email" class="block text-sm font-medium text-gray-700">Email</label>
        <input type="email" v-model="email" id="email" class="mt-1 block w-full border border-gray-300 rounded-md shadow-sm py-2 px-3 focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm" required>
      </div>
      <div class="mb-4">
        <label for="role" class="block text-sm font-medium text-gray-700">Role</label>
        <select v-model="role" id="role" class="mt-1 block w-full border border-gray-300 rounded-md shadow-sm py-2 px-3 focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm" required>
          <option value="Customer">Customer</option>
          <option value="Employee">Employee</option>
        </select>
      </div>
      <div v-if="error" class="mb-4 text-red-500">
        {{ error }}
      </div>
      <div class="flex items-center justify-between">
        <button type="submit" class="inline-flex justify-center py-2 px-4 border border-transparent shadow-sm text-sm font-medium rounded-md text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500">
          Register
        </button>
      </div>
    </form>
    <p class="mt-4">Already have an account? <router-link to="/login" class="text-indigo-600">Login</router-link></p>
  </div>
</template>

<script setup>
import {ref} from 'vue';
import {useAuth} from '../composables/useAuth';

const firstName = ref('');
const lastName = ref('');
const username = ref('');
const password = ref('');
const phoneNumber = ref('');
const email = ref('');
const role = ref('Customer');
const {register, error} = useAuth();

const registerUser = async () => {
  await register({
    firstName: firstName.value,
    lastName: lastName.value,
    username: username.value,
    password: password.value,
    phoneNumber: phoneNumber.value,
    email: email.value,
    role: role.value,
  });
};
</script>
